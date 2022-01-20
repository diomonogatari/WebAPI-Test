
echo "====================="
echo "====== Volumes ======"
echo "====================="
docker volume create --name=sqlserverdata


# Rebuild all the services that have changes
echo "====================="
echo "==== Force build ===="
echo "====================="
docker-compose build --force-rm
