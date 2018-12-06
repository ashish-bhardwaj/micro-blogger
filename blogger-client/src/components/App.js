import React, { Component } from 'react';
import BlogList from './blogList.js';
import './styles/App.css';
import CreateBlog from './createBlog.js';
import Header from './client/header.js'
import { Switch, Route } from 'react-router-dom'

class App extends Component {
  constructor(props){
    super(props);
    this.blogAdded = this.blogAdded.bind(this);
  }

  blogAdded(e) {
    e.preventDefault();
    this.setState( (prev) => ({
      blogs: prev
    }));
  }

  render() {
    return (
      <div className="center w85">
        <Header />
        <div className="ph3 pv1 background-gray">
          <Switch>
            <Route exact path="/" component={BlogList} />
            <Route exact path="/create" onSave={this.blogAdded} component={CreateBlog} />
          </Switch>
        </div>
      </div>
    )
  }
}

export default App;
