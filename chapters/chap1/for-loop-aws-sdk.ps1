# Powershell script that loops through Cloud9 to get environment information

$cloud9Env = @{ env1 = "18acd120518340df8a73ccaab641851e";
                env2 = "2c9eb66bf53b4083b9ab6345bae70dad"; 
                env3 = "f104b0141c284a41af0c75fea7890770" }

foreach ($env in $cloud9Env.GetEnumerator()) {
            Write-Host "Information for $($env.Key):";
            Get-C9EnvironmentData $($env.Value)
}
