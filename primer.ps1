choco install sqllocaldb -yr
choco install sql-server-2017-cumulative-update -yr
choco install sqlserver-cmdlineutils -yr

Add-LocalDb PopulationHealth "$PSScriptRoot\.db"

build PopulationHealth