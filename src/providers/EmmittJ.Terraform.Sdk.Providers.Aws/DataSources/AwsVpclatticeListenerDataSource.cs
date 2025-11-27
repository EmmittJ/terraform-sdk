using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpclattice_listener Terraform data source.
/// Retrieves information about a aws_vpclattice_listener.
/// </summary>
public partial class AwsVpclatticeListenerDataSource(string name) : TerraformDataSource("aws_vpclattice_listener", name)
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
    /// The listener_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerIdentifier is required")]
    public required TerraformValue<string> ListenerIdentifier
    {
        get => new TerraformReference<string>(this, "listener_identifier");
        set => SetArgument("listener_identifier", value);
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
    /// The service_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceIdentifier is required")]
    public required TerraformValue<string> ServiceIdentifier
    {
        get => new TerraformReference<string>(this, "service_identifier");
        set => SetArgument("service_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefaultAction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "default_action").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedAt
    {
        get => new TerraformReference<string>(this, "last_updated_at");
    }

    /// <summary>
    /// The listener_id attribute.
    /// </summary>
    public TerraformValue<string> ListenerId
    {
        get => new TerraformReference<string>(this, "listener_id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceArn
    {
        get => new TerraformReference<string>(this, "service_arn");
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
    }

}
