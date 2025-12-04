using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for notification in AwsGlacierVault.
/// Nesting mode: list
/// </summary>
public class AwsGlacierVaultNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public required TerraformSet<string> Events
    {
        get => GetArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The sns_topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopic is required")]
    public required TerraformValue<string> SnsTopic
    {
        get => GetArgument<TerraformValue<string>>("sns_topic");
        set => SetArgument("sns_topic", value);
    }

}


/// <summary>
/// Represents a aws_glacier_vault Terraform resource.
/// Manages a aws_glacier_vault resource.
/// </summary>
public partial class AwsGlacierVault(string name) : TerraformResource("aws_glacier_vault", name)
{
    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformValue<string>? AccessPolicy
    {
        get => GetArgument<TerraformValue<string>>("access_policy");
        set => SetArgument("access_policy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// Notification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notification block(s) allowed")]
    public TerraformList<AwsGlacierVaultNotificationBlock>? Notification
    {
        get => GetArgument<TerraformList<AwsGlacierVaultNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

}
