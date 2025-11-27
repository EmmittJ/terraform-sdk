using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_db_servers Terraform data source.
/// Retrieves information about a aws_odb_db_servers.
/// </summary>
public partial class AwsOdbDbServersDataSource(string name) : TerraformDataSource("aws_odb_db_servers", name)
{
    /// <summary>
    /// The cloud exadata infrastructure ID. Mandatory field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// List of database servers associated with cloud_exadata_infrastructure_id.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbServers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "db_servers").ResolveNodes(ctx));
    }

}
