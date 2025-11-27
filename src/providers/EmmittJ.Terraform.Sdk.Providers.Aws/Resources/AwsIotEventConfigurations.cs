using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_event_configurations Terraform resource.
/// Manages a aws_iot_event_configurations resource.
/// </summary>
public partial class AwsIotEventConfigurations(string name) : TerraformResource("aws_iot_event_configurations", name)
{
    /// <summary>
    /// The event_configurations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventConfigurations is required")]
    public required TerraformMap<bool> EventConfigurations
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "event_configurations").ResolveNodes(ctx));
        set => SetArgument("event_configurations", value);
    }

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

}
