using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lakeformation_identity_center_configuration Terraform resource.
/// Manages a aws_lakeformation_identity_center_configuration resource.
/// </summary>
public partial class AwsLakeformationIdentityCenterConfiguration(string name) : TerraformResource("aws_lakeformation_identity_center_configuration", name)
{
    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The ARN of the Identity Center instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformValue<string> ApplicationArn
        => AsReference("application_arn");

    /// <summary>
    /// The resource_share attribute.
    /// </summary>
    public TerraformValue<string> ResourceShare
        => AsReference("resource_share");

}
