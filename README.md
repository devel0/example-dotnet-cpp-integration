# example dotnet cpp integration

## how this project was built

```sh
mkdir example-dotnet-cpp-integration
cd example-dotnet-cpp-integration
git init
curl -s https://raw.githubusercontent.com/github/gitignore/master/VisualStudio.gitignore -o .gitignore
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
