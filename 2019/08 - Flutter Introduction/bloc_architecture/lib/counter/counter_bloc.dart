import 'dart:async';

import 'package:bloc_architecture/counter/counter_provider.dart';

class CounterBloc {
  final counterController = StreamController(); // create a StreamController
  final CounterProvider provider =
      CounterProvider(); // create an instance of our CounterProvider

  Stream get getCount =>
      counterController.stream; // create a getter for our stream

  void updateCount() {
    provider
        .increaseCount(); // call the method to increase our count in the provider
    counterController.sink.add(provider.count); // add the count to our sink
  }

  void dispose() {
    counterController.close(); // close our StreamController
  }
}

final bloc = CounterBloc(); // create an instance of the counter bloc
