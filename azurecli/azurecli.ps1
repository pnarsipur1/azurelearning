az group create --name learn-private-rg1 --location "West India" &&
az deployment group create --resource-group learn-private-rg1 \
--parameters language=".net" helloWorld="true" webAppName="<app-name>" \
--template path"E:\azurelearning\azurelearning\webapp.json"