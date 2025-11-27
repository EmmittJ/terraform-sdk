using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpclattice_service_network Terraform data source.
/// Retrieves information about a aws_vpclattice_service_network.
/// </summary>
public partial class AwsVpclatticeServiceNetworkDataSource(string name) : TerraformDataSource("aws_vpclattice_service_network", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    public required TerraformValue<string> ServiceNetworkIdentifier
    {
        get => new TerraformReference<string>(this, "service_network_identifier");
        set => SetArgument("service_network_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedAt
    {
        get => new TerraformReference<string>(this, "last_updated_at");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The number_of_associated_services attribute.
    /// </summary>
    public TerraformValue<double> NumberOfAssociatedServices
    {
        get => new TerraformReference<double>(this, "number_of_associated_services");
    }

    /// <summary>
    /// The number_of_associated_vpcs attribute.
    /// </summary>
    public TerraformValue<double> NumberOfAssociatedVpcs
    {
        get => new TerraformReference<double>(this, "number_of_associated_vpcs");
    }

}
