FROM mcr.microsoft.com/dotnet/sdk:7.0 as Development
RUN apt-get update && apt-get install -y \
  nano \
  ssh \
  && rm -rf /var/lib/apt/lists/*
RUN useradd -m vladimir
USER vladimir
WORKDIR /home/vladimir
RUN umask 022 && export LS_OPTIONS='--color=auto' && dircolors -p > .dircolors
ENV TERM=xterm-256color
RUN git config --global user.email "vladimir@mikhailov.in" && git config --global user.name "Vladimir"
