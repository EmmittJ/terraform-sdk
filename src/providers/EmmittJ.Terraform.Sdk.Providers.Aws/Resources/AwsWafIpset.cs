using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_set_descriptors in AwsWafIpset.
/// Nesting mode: set
/// </summary>
public class AwsWafIpsetIpSetDescriptorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_set_descriptors";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_waf_ipset Terraform resource.
/// Manages a aws_waf_ipset resource.
/// </summary>
public partial class AwsWafIpset(string name) : TerraformResource("aws_waf_ipset", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// IpSetDescriptors block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafIpsetIpSetDescriptorsBlock>? IpSetDescriptors
    {
        get => GetArgument<TerraformSet<AwsWafIpsetIpSetDescriptorsBlock>>("ip_set_descriptors");
        set => SetArgument("ip_set_descriptors", value);
    }

}
