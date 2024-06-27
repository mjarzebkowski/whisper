# Whisper

Blazor with AI, ArangoDB and Weaviate

Oryginally I wish to use ORient DB, byt support for .Net looks poor (Nuget updates 5 y ago)... so I chose ArangoDB.
Its test project; There are few goals to obtain:

- Discover how multi-model database can be used in real app. Usually it will be Postgres and Dapper, but want to test something new
- Discover how to integrate .Net with Weaviate, my first chose vestor db
- Blazor app - test few external components
- Integrate local Ollama and OpenAI-4o chat
- See 3D model in blazor
- Finally be able to talk to AI assistant about notes and shopping list and other things. See its 3D model on screen, maybe in some kind of hololeans.

## Usage

Should work on Docker - use docker-compose

Natively:
Configure connection in appsettings.json , section "connection" and start .Net service. 

Kubernetes support - coming soon

## Support

Time to time 'll check slack, fill free to join and ask
https://join.slack.com/t/whisperappworkspace/shared_invite/zt-2lqc3ur4j-P2~6GiFPY7Y5X3w2FimI8g

## Roadmap

Avalible soon

## Contributing

State if you are open to contributions and what your requirements are for accepting them.

For people who want to make changes to your project, it's helpful to have some documentation on how to get started. Perhaps there is a script that they should run or some environment variables that they need to set. Make these steps explicit. These instructions could also be useful to your future self.

You can also document commands to lint the code or run tests. These steps help to ensure high code quality and reduce the likelihood that the changes inadvertently break something. Having instructions for running tests is especially helpful if it requires external setup, such as starting a Selenium server for testing in a browser.

## Authors and acknowledgment

Maciej Jarzębkowski

## License

GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007

## Project status

Active development
