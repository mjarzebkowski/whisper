terraform {
  source = "../../modules/kubernetes"
}

inputs = {
  cluster_name = "prod-cluster-name"
  region       = "prod-region"
  # inne zmienne
}
