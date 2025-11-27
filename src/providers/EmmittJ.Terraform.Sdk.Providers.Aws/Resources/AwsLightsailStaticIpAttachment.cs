using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_static_ip_attachment Terraform resource.
/// Manages a aws_lightsail_static_ip_attachment resource.
/// </summary>
public partial class AwsLightsailStaticIpAttachment(string name) : TerraformResource("aws_lightsail_static_ip_attachment", name)
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
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
        set => SetArgument("instance_name", value);
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
    /// The static_ip_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticIpName is required")]
    public required TerraformValue<string> StaticIpName
    {
        get => new TerraformReference<string>(this, "static_ip_name");
        set => SetArgument("static_ip_name", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

}
