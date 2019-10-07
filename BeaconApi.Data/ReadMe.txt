dotnet tool install --local dotnet-ef --version 2.2.4

dotnet ef migrations add pts_init --project "BeaconApi.Data" --startup-project "BeaconApi.Api"

dotnet ef database update --project "BeaconApi.Data" --startup-project "BeaconApi.Api"