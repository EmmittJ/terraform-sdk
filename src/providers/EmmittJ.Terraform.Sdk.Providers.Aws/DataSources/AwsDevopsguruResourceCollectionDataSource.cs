using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_devopsguru_resource_collection Terraform data source.
/// Retrieves information about a aws_devopsguru_resource_collection.
/// </summary>
public partial class AwsDevopsguruResourceCollectionDataSource(string name) : TerraformDataSource("aws_devopsguru_resource_collection", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The cloudformation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cloudformation
        => AsReference("cloudformation");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Tags
        => AsReference("tags");

}
