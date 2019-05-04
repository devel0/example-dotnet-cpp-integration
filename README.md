# example dotnet cpp integration

## how this project was built

```sh
mkdir example-dotnet-cpp-integration
cd example-dotnet-cpp-integration
git init
curl -s https://raw.githubusercontent.com/github/gitignore/master/VisualStudio.gitignore -o .gitignore
echo "*.so" >> .gitignore
echo "*.o" >> .gitignore
curl -s https://api.github.com/licenses/mit | jq -r ".body" | sed "s/\[year\]/$(date +%Y)/g" | sed "s/\[fullname\]/myname/g" > LICENSE

dotnet new console -n dotnet-app
code .
```

- initial import

```sh
git remote add origin https://github.com/devel0/example-dotnet-cpp-integration.git
git add --all
git commit -m "initial commit"
git push -u origin master
```

## execution

- hit F5 on vscode

```
1+2=3
sample message iteration n.0
sample message iteration n.1
sample message iteration n.2
sample message iteration n.3
sample message iteration n.4
sample message iteration n.5
sample message iteration n.6
sample message iteration n.7
sample message iteration n.8
sample message iteration n.9
```

## remarks

- [dependant task](https://github.com/devel0/example-dotnet-cpp-integration/blob/df9004b02cb4b90a5640b6259a36d4c0a0b4a97a/.vscode/tasks.json#L14) before to build
- makefile [LIBRARY](https://github.com/devel0/example-dotnet-cpp-integration/blob/df9004b02cb4b90a5640b6259a36d4c0a0b4a97a/.vscode/tasks.json#L20) var override to out .so file in the dotnet bin folder
- cpp makefile ensured output library folder [exists](https://github.com/devel0/example-dotnet-cpp-integration/blob/df9004b02cb4b90a5640b6259a36d4c0a0b4a97a/cpp-library/Makefile#L11)
- csharp [dll method import](https://github.com/devel0/example-dotnet-cpp-integration/blob/df9004b02cb4b90a5640b6259a36d4c0a0b4a97a/dotnet-app/Program.cs#L8-L9)
