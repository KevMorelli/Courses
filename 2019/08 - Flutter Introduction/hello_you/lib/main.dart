import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Hello Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: HelloYou(),
    );
  }
}

class HelloYou extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => _HelloYouState();
}

class _HelloYouState extends State<HelloYou> {
  var name = '';
  var greetings = ['Hello', 'Goodbye'];
  var greeting = 'Hello';

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Hello'),
        backgroundColor: Colors.blueAccent,
      ),
      body: Container(
        padding: EdgeInsets.all(15.0),
        child: Column(
          children: <Widget>[
            TextField(
              decoration: InputDecoration(hintText: 'Please insert your name'),
              onChanged: (String string) {
                setState(() {
                  name = string;
                });
              },
            ),
            DropdownButton<String>(
                items: greetings.map((String value) {
                  return DropdownMenuItem<String>(
                    value: value,
                    child: Text(value),
                  );
                }).toList(),
                value: greeting,
                onChanged: (String value) {
                  _onDropdownChange(value);
                }),
            Text(greeting + ' ' + name + '!')
          ],
        ),
      ),
    );
  }

  _onDropdownChange(String value) {
    setState(() {
      greeting = value;
    });
  }
}
