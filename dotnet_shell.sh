#!/bin/bash

# Get the list of projects from the command line
PROJECTS=$1


#There is  comma in the projects so we need to split them
DELIMETER=","
if [[ "$PROJECTS" == *"$DELIMETER"* ]]; 

then
  #spliting the projects and put them into an array
  IFS="$DELIMETER" read -ra PROJS_ARRAY <<< "$PROJECTS"

  for i in "${PROJS_ARRAY[@]}"
  do
  	echo "Running $i"
  	dotnet run --project $i
  	wait
  done
else
	echo "running $PROJECTS"
	dotnet run --project $PROJECTS
fi


