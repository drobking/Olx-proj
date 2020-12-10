import React, { Component } from 'react';
import { OlxService } from './api-authorization/OlxService';

export class CategoryMenu extends Component{
   
    constructor(olxService:OlxService){

    }
render(){
    olxService.GetCategories();
    return(
        
        <div className="d-flex justify-content-center">
            <div className="col-3 bg-secondary">
                <img alt="image"></img>
                <p>Name categoria</p>
            </div>
            <div className="col-3 bg-secondary">
                <img alt="image"></img>
                <p>Name categoria</p>
            </div>
            <div className="col-3 bg-secondary">
                <img alt="image"></img>
                <p>Name categoria</p>
            </div>
            <div className="col-3 bg-secondary">
                <img alt="image"></img>
                <p>Name categoria</p>
            </div>
        </div>
    )}
}