import React, { Component } from 'react';

export class Home extends Component {
    displayName = Home.name

    constructor(props) {
        super(props);
        this.state = { text: "", sentences: [], text1: "" };

        this.selectFile = this.selectFile.bind(this);
        this.inputWord = this.inputWord.bind(this);
    }

    selectFile(e) {
        var file = e.target.files[0];
        if (file.size !== 0) {
            var reader = new FileReader();
            reader.readAsText(file);
            reader.onload = () => this.setState({ text: reader.result });
        }
        else {
            alert("File is empty");
        }
    }

    inputWord(e) {
        if (e.length > 0) {
            var text = this.state.text.split(/[!.?]/);
            for (var i = 0; i < text.length; i++) {
                if (text[i].search(e) !== -1) {
                    this.state.sentences.push(text[i]);
                }
            }
            this.forceUpdate();
        }
        else {
            alert("You have empty field");
        }
    }

    render() {
        var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    return (
        <div>
            <div className="textBlock">{this.state.text}</div>
            <input className="textFild" onChange={this.selectFile} accept=".txt, .docx, .rtf" type="file"></input>
            <input required id="word" type="text"/>
            <button onClick={() => this.inputWord(document.getElementById("word").value)}>Search</button>
            <div className="textBlock">{this.state.sentences.map(s => <li key={
                possible.charAt(Math.floor(Math.random() * possible.length)) + 
                possible.charAt(Math.floor(Math.random() * possible.length)) +
                possible.charAt(Math.floor(Math.random() * possible.length))
            }>{s}</li>)}</div>
      </div>
    );
  }
}
