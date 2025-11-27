using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_pinpointsmsvoicev2_configuration_set Terraform resource.
/// Manages a aws_pinpointsmsvoicev2_configuration_set resource.
/// </summary>
public partial class AwsPinpointsmsvoicev2ConfigurationSet(string name) : TerraformResource("aws_pinpointsmsvoicev2_configuration_set", name)
{
    /// <summary>
    /// The default_message_type attribute.
    /// </summary>
    public TerraformValue<string>? DefaultMessageType
    {
        get => new TerraformReference<string>(this, "default_message_type");
        set => SetArgument("default_message_type", value);
    }

    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultSenderId
    {
        get => new TerraformReference<string>(this, "default_sender_id");
        set => SetArgument("default_sender_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
