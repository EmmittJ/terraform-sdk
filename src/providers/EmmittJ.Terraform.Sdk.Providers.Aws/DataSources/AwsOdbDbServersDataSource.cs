using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_servers.
/// </summary>
public class AwsOdbDbServersDataSource : TerraformDataSource
{
    public AwsOdbDbServersDataSource(string name) : base("aws_odb_db_servers", name)
    {
    }

    /// <summary>
    /// The cloud exadata infrastructure ID. Mandatory field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// List of database servers associated with cloud_exadata_infrastructure_id.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DbServers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "db_servers");

}
