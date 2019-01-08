import React, { Component } from 'react';
import './App.css';

import Card from './Components/Card';
import Form from './Components/Form';

//Data
import { todos } from './todos.json';

class App extends Component {
  constructor() {
    super();
    this.state = {
      todos
    }
    this.handleAddTodo = this.handleAddTodo.bind(this);
  }

  removeTodo(index) {
      this.setState({
        todos: this.state.todos.filter((e, i) => {
          return i !== index
        })
      });
  }

  handleAddTodo(todo) {
    this.setState({
      todos: [...this.state.todos, todo]
    })
  }

  render() {
    const todos = this.state.todos.map((todo, i) => {
      return (
          <Card title={todo.title} priority={todo.priority} description={todo.description} number={i} parent={this}/>
      )
    })

    return (
      <div className="App">
        <nav className="navbar sticky-top navbar-expand-lg navbar-dark bg-dark">
          <a className="navbar-brand" href="/">
              Tasks
              <span className="badge badge-pill badge-light ml-2">
                  {this.state.todos.length}
              </span>
          </a>
        </nav>
        <div className="container">
          <div className="row mt-4">
            <div className="col-md-4 text-center">
              <Form onAddTodo={this.handleAddTodo}></Form>
            </div>

            <div className="col-md-8">
              <div className="row">
                {todos}
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default App;
