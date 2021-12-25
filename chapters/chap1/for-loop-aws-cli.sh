#!/usr/bin/env bash
# Loop through a list of Cloud9 Environments to find out more information
 
declare -A cloud9Env=([env1]="18acd120518340df8a73ccaab641851e"\
    [env2]="2c9eb66bf53b4083b9ab6345bae70dad"\
    [env3]="f104b0141c284a41af0c75fea7890770" ) 

## now loop through the above hash to get more information
for env in "${!cloud9Env[@]}"; do
   echo "Information for $env: "
   aws cloud9 describe-environments --environment-id "${cloud9Env[$env]}"
done