Criação do Projeto Wijshied
projeto utiliza-se de imagem Docker Linux
imagem esta disponível em nelsonneto234/wijsheid

## Introduction

This is a simple pipeline example for a .NET Core application, showing just
how easy it is to get up and running with .NET development using GitLab.

# Reference links

- [GitLab CI Documentation]  (https://docs.gitlab.com/ee/ci/)
- [.NET Hello World tutorial]  (https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/)

If you're new to .NET you'll want to check out the tutorial, but if you're
already a seasoned developer considering building your own .NET app with GitLab,
this should all look very familiar.

```sh
$ cd dillinger
$ npm install -d
docker build -t wijsheid:1.0.1 .
docker run -d -p 8000:8080 --restart="always" <youruser>/dillinger:${package.json.version}
127.0.0.1:8000
```
