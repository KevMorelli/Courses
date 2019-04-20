import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Trip Cost Calculator',
      home: FuelForm(),
    );
  }
}

class FuelForm extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => _FuelFormState();
}

class _FuelFormState extends State<FuelForm> {
  TextEditingController distanceController = TextEditingController();
  TextEditingController avgController = TextEditingController();
  TextEditingController priceController = TextEditingController();

  final formDistance = 5.0;
  final currencies = ['Dollars', 'Euro', 'Pesos'];
  var currency = 'Dollars';
  var result = '';

  @override
  Widget build(BuildContext context) {
    TextStyle textStyle = Theme.of(context).textTheme.title;
    return Scaffold(
      appBar: AppBar(
        title: Text('Trip Cost Calculator'),
      ),
      body: Container(
        padding: EdgeInsets.all(15.0),
        child: Column(
          children: <Widget>[
            Padding(
              child: TextField(
                controller: distanceController,
                decoration: InputDecoration(
                    labelText: 'Distance',
                    hintText: 'e.g. 124',
                    labelStyle: textStyle,
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(5.0))),
                keyboardType: TextInputType.number,
              ),
              padding: EdgeInsets.only(top: formDistance, bottom: formDistance),
            ),
            Padding(
              padding: EdgeInsets.only(top: formDistance, bottom: formDistance),
              child: TextField(
                controller: avgController,
                decoration: InputDecoration(
                    labelText: 'Distance per unit',
                    hintText: 'e.g. 17',
                    labelStyle: textStyle,
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(5.0))),
                keyboardType: TextInputType.number,
              ),
            ),
            Padding(
              padding: EdgeInsets.only(top: formDistance, bottom: formDistance),
              child: Row(
                children: <Widget>[
                  Expanded(
                    child: TextField(
                      controller: priceController,
                      decoration: InputDecoration(
                          labelText: 'Price',
                          hintText: 'e.g. 1.65',
                          labelStyle: textStyle,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(5.0))),
                      keyboardType: TextInputType.number,
                    ),
                  ),
                  Container(
                    width: formDistance * 5,
                  ),
                  Expanded(
                    child: DropdownButton<String>(
                      value: currency,
                      items: currencies.map((String value) {
                        return DropdownMenuItem(
                          value: value,
                          child: Text(value),
                        );
                      }).toList(),
                      onChanged: (String value) {
                        _onDropdownChanged(value);
                      },
                    ),
                  ),
                ],
              ),
            ),
            Row(
              children: <Widget>[
                Expanded(
                  child: RaisedButton(
                    color: Theme.of(context).primaryColorDark,
                    textColor: Theme.of(context).primaryColorLight,
                    child: Text(
                      'Submit',
                      textScaleFactor: 1.5,
                    ),
                    onPressed: () {
                      setState(() {
                        result = _calculate();
                      });
                    },
                  ),
                ),
                Container(
                  width: formDistance * 5,
                ),
                Expanded(
                  child: RaisedButton(
                    color: Theme.of(context).buttonColor,
                    textColor: Theme.of(context).primaryColorDark,
                    child: Text(
                      'Reset',
                      textScaleFactor: 1.5,
                    ),
                    onPressed: () {
                      _reset();
                    },
                  ),
                ),
              ],
            ),
            Text(result),
          ],
        ),
      ),
    );
  }

  _onDropdownChanged(String value) {
    setState(() {
      currency = value;
    });
  }

  String _calculate() {
    double _distance = double.parse(distanceController.text);
    double _fuelCost = double.parse(priceController.text);
    double _consumption = double.parse(avgController.text);

    double _totalCost = _distance / _consumption * _fuelCost;

    var _result = 'The total cost of your trip is ' +
        _totalCost.toStringAsFixed(2) +
        ' ' +
        currency;

    return _result;
  }

  _reset() {
    distanceController.text = '';
    priceController.text = '';
    avgController.text = '';

    setState(() {
      result = '';
    });
  }
}
