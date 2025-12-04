using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_lag Terraform resource.
/// Manages a aws_dx_lag resource.
/// </summary>
public partial class AwsDxLag(string name) : TerraformResource("aws_dx_lag", name)
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The connections_bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionsBandwidth is required")]
    public required TerraformValue<string> ConnectionsBandwidth
    {
        get => GetArgument<TerraformValue<string>>("connections_bandwidth");
        set => SetArgument("connections_bandwidth", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => GetArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
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
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformValue<string> HasLogicalRedundancy
        => AsReference("has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
        => AsReference("jumbo_frame_capable");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

}
