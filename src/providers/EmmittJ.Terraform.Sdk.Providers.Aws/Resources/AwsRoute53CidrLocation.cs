using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_cidr_location Terraform resource.
/// Manages a aws_route53_cidr_location resource.
/// </summary>
public partial class AwsRoute53CidrLocation(string name) : TerraformResource("aws_route53_cidr_location", name)
{
    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlocks is required")]
    public required TerraformSet<string> CidrBlocks
    {
        get => GetRequiredArgument<TerraformSet<string>>("cidr_blocks");
        set => SetArgument("cidr_blocks", value);
    }

    /// <summary>
    /// The cidr_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrCollectionId is required")]
    public required TerraformValue<string> CidrCollectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr_collection_id");
        set => SetArgument("cidr_collection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

}
