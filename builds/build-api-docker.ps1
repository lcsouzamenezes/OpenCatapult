param(
    [switch]$nobuild=$False
)

$env:LOCAL_HTTP_PORT=8006
$env:LOCAL_HTTPS_PORT=44306
$env:LOCAL_HTTPS_PATH="$env:APPDATA\ASP.NET\Https"
$env:CERTIFICATE_FILE="aspnetapp.pfx"
$env:CERTIFICATE_PASSWORD="aspnetcertpass"

$env:ASPNETCORE_ENVIRONMENT="Development"
$env:ASPNETCORE_URLS="https://+;http://+"
$env:ASPNETCORE_HTTPS_PATH="/root/.dotnet/https"

dotnet dev-certs https -ep "$LOCAL_HTTPS_PATH\$CERTIFICATE_FILE" -p $CERTIFICATE_PASSWORD

dotnet dev-certs https --trust

if ($nobuild) {
    docker-compose up
} else {
    docker-compose up --build
}