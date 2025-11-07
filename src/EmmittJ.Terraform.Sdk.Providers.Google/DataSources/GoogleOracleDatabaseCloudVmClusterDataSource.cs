using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_cloud_vm_cluster.
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseCloudVmClusterDataSource(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_odb_subnet");
        this.DeclareOutput("backup_subnet_cidr");
        this.DeclareOutput("cidr");
        this.DeclareOutput("create_time");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("display_name");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("exadata_infrastructure");
        this.DeclareOutput("gcp_oracle_zone");
        this.DeclareOutput("labels");
        this.DeclareOutput("name");
        this.DeclareOutput("network");
        this.DeclareOutput("odb_network");
        this.DeclareOutput("odb_subnet");
        this.DeclareOutput("properties");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    public TerraformProperty<string>? CloudVmClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => this.WithProperty("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformExpression BackupOdbSubnet => this["backup_odb_subnet"];

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    public TerraformExpression BackupSubnetCidr => this["backup_subnet_cidr"];

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    public TerraformExpression Cidr => this["cidr"];

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    public TerraformExpression ExadataInfrastructure => this["exadata_infrastructure"];

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    public TerraformExpression GcpOracleZone => this["gcp_oracle_zone"];

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformExpression OdbNetwork => this["odb_network"];

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformExpression OdbSubnet => this["odb_subnet"];

    /// <summary>
    /// Various properties and settings associated with Exadata VM cluster.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
