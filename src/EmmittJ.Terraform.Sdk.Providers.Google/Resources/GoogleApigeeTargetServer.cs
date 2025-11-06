using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_target_server resource.
/// </summary>
public class GoogleApigeeTargetServer : TerraformResource
{
    public GoogleApigeeTargetServer(string name) : base("google_apigee_target_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A human-readable description of this TargetServer.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    public string? EnvId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("env_id")?.Value;
        set => this.WithProperty("env_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
    /// </summary>
    public string? Host
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host")?.Value;
        set => this.WithProperty("host", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
    /// </summary>
    public bool? IsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_enabled")?.Value;
        set => this.WithProperty("is_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Immutable. The protocol used by this TargetServer. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;GRPC_TARGET&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;EXTERNAL_CALLOUT&amp;quot;]
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
