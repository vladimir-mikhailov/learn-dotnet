# .NET Development in Docker Container

## Build custom image

`docker image build -t dotnet-custom`

---

## Run image

Make a directory for your app: `mkdir myapp && cd myapp`

Run Docker container:

```bash
docker run -it --rm\
  --name my-dotnet-app \
  --hostname docker \
  -v $(pwd):/home/vladimir/${PWD##*/}${NC} \
  -w /home/vladimir/${PWD##*/} \
  dotnet-custom
```

- Run new container `docker run` and name it `--name my-dotnet-app`.
- Stay inside the container: `-it`.
- Autoremove the container after exit: `-rm`.
- Mount current folder as a volume: `-v $(pwd)` mounted to image's WORKDIR.
- Specify container's WORKDIR: `-w /app`.
- Use official Microsoft .NET SDK image: `mcr.microsoft.com/dotnet/sdk:6.0` or custom image: `dotnet-custom`.

---

## Remove .NET locally

Version info: `dotnet --info`

```bash
SDKversion="6.0.400"
version="6.0.8"
sudo rm -rf /usr/local/share/dotnet/sdk/$SDKversion
sudo rm -rf /usr/local/share/dotnet/shared/Microsoft.NETCore.App/$version
sudo rm -rf /usr/local/share/dotnet/shared/Microsoft.AspNetCore.All/$version
sudo rm -rf /usr/local/share/dotnet/shared/Microsoft.AspNetCore.App/$version
sudo rm -rf /usr/local/share/dotnet/host/fxr/$version
```

or

`sudo rm -rf /usr/local/share/dotnet`
