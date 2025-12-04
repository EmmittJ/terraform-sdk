using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_outposts_outpost_instance_type Terraform data source.
/// Retrieves information about a aws_outposts_outpost_instance_type.
/// </summary>
public partial class AwsOutpostsOutpostInstanceTypeDataSource(string name) : TerraformDataSource("aws_outposts_outpost_instance_type", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public TerraformList<string>? PreferredInstanceTypes
    {
        get => GetArgument<TerraformList<string>>("preferred_instance_types");
        set => SetArgument("preferred_instance_types", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
