import React, { Component } from 'react';
import StormTrooper from './StormTrooper';

import logo from './logo.svg';
import './App.css';

export default class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          <StormTrooper/>
          <StormTrooper/>
        </p>
      </div>
    );
  }
}
