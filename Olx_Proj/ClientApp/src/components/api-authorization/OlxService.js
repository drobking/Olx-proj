
export class OlxService{
    constructor(props) {
        super(props);
        this.state = {
          error: null,
          isLoaded: false,
          categories:[]
        };
      }

    GetCategories() {
      
        const response = await fetch("https://localhost:44322/api/Olx", {
            method: "GET", // *Type of request GET, POST, PUT, DELETE
            headers: {
              "Content-Type": "application/json" // request content type
            },
            redirect: "follow", // manual, *follow, error
            referrerPolicy: "no-referrer", // no-referrer, *client
            // body: JSON.stringify(data) // Attach body with the request
          });
          this.setState({ categories: await response.json() });
          console.log(this.state.categories);
      }
} 

const olxService = new OlxService();

export default olxService;