param(
    [switch]$nobuild=$False
)

$env:API_CONTAINER_NAME="oc-api"
$env:MSSQLDB_CONTAINER_NAME="oc-mssqldb"

$env:LOCAL_HTTP_PORT=8006
$env:LOCAL_HTTPS_PORT=44306
$env:LOCAL_HTTPS_PATH="$env:APPDATA\ASP.NET\Https"
$env:LOCAL_MSSQL_PATH="$env:APPDATA\MSSQL"
$env:CERTIFICATE_FILE="aspnetapp.pfx"
$env:CERTIFICATE_PASSWORD="aspnetcertpass"

$env:ASPNETCORE_ENVIRONMENT="Development"
$env:ASPNETCORE_URLS="https://+;http://+"
$env:ASPNETCORE_HTTPS_PATH="/root/.dotnet/https"

$env:SA_PASSWORD="kkQ2BnOu2e7k6it"
$env:CONNECTION_STRING="Server=localhost;Database=opencatapult-db;User ID=sa;Password=$SA_PASSWORD;"

dotnet dev-certs https -ep "$LOCAL_HTTPS_PATH\$CERTIFICATE_FILE" -p $CERTIFICATE_PASSWORD

dotnet dev-certs https --trust

if ($nobuild) {
    docker-compose up -d
} else {
    docker-compose up --build -d
}