terraform {
  source = "../../modules/kubernetes"
}

inputs = {
  cluster_name = "test-cluster-name"
  region       = "test-region"
  # inne zmienne
}
