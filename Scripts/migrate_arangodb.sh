#!/bin/bash

ARANGO_HOST="localhost"
ARANGO_PORT="8529"
ARANGO_DB="your_database"
ARANGO_USER="root"
ARANGO_PASSWORD="root_password"

# Przykład migracji: tworzenie kolekcji
arangosh --server.endpoint tcp://${ARANGO_HOST}:${ARANGO_PORT} --server.database ${ARANGO_DB} --server.username ${ARANGO_USER} --server.password ${ARANGO_PASSWORD} --javascript.execute-string 'db._create("testCollection");'

# Możesz dodać więcej migracji w ten sposób
# arangosh --server.endpoint tcp://${ARANGO_HOST}:${ARANGO_PORT} --server.database ${ARANGO_DB} --server.username ${ARANGO_USER} --server.password ${ARANGO_PASSWORD} --javascript.execute-string 'db.testCollection.ensureIndex({ type: "hash", fields: ["name"], unique: true });'
