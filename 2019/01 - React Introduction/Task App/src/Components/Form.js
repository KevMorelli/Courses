import React, { Component } from 'react'

class Form extends Component {
    constructor () {
        super();
        this.state = {
          title: '',
          responsible: '',
          description: '',
          priority: 'Low'
        };
        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    
    handleSubmit(e) {
        e.preventDefault();
        this.props.onAddTodo(this.state);
        this.setState({
            title: '',
            responsible: '',
            description: '',
            priority: 'Low'
        });
    }
    
    handleInputChange(e) {
        const {value, name} = e.target;
        console.log(value, name);
        this.setState({
            [name]: value
        });
    }

    render() {
        return (
            <div className="card mt-4">
                <form onSubmit={this.handleSubmit} className="card-body">
                <div className="form-group">
                    <input
                    type="text"
                    name="title"
                    className="form-control"
                    value={this.state.title}
                    onChange={this.handleInputChange}
                    placeholder="Title"
                    required
                    />
                </div>
                <div className="form-group">
                    <input
                    type="text"
                    name="description"
                    className="form-control"
                    value={this.state.description}
                    onChange={this.handleInputChange}
                    placeholder="Description"
                    />
                </div>
                <div className="form-group">
                    <select
                        name="priority"
                        className="form-control"
                        value={this.state.priority}
                        onChange={this.handleInputChange}
                    >
                    <option>Low</option>
                    <option>Medium</option>
                    <option>High</option>
                    </select>
                </div>
                <button type="submit" className="btn btn-sm btn-primary">
                    Save
                </button>
                </form>
            </div>
        )
    }
}

export default Form;