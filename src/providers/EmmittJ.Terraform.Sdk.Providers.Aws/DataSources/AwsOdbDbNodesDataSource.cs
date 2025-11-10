using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_nodes.
/// </summary>
public class AwsOdbDbNodesDataSource : TerraformDataSource
{
    public AwsOdbDbNodesDataSource(string name) : base("aws_odb_db_nodes", name)
    {
    }

    /// <summary>
    /// Id of the cloud VM cluster. The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformPropertyName("cloud_vm_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudVmClusterId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The list of DB nodes along with their properties.
    /// </summary>
    [TerraformPropertyName("db_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DbNodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "db_nodes");

}
