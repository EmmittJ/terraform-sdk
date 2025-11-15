namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the cloud block configuration for HCP Terraform or Terraform Enterprise.
/// Provides state storage, remote execution, and other cloud-based features.
/// Mutually exclusive with backend configuration.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/terraform#cloud"/></para>
/// </remarks>
public partial class TerraformCloudBlock : ITerraformResolvable
{
    private readonly Dictionary<string, ITerraformValue> _properties = new();

    /// <summary>
    /// Initializes a new instance of TerraformCloudBlock.
    /// </summary>
    public TerraformCloudBlock() { }

    /// <summary>
    /// Gets or sets the name of the organization to connect to.
    /// Required when connecting to HCP Terraform.
    /// Can be overridden by TF_CLOUD_ORGANIZATION environment variable.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>?>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Gets or sets the hostname for a Terraform Enterprise deployment.
    /// Default: "app.terraform.io" (HCP Terraform)
    /// Can be overridden by TF_CLOUD_HOSTNAME environment variable.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => GetArgument<TerraformValue<string>?>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Gets or sets the authentication token for HCP Terraform.
    /// We recommend omitting this and using 'terraform login' or CLI config file instead.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>?>("token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// Gets or sets the workspaces block configuration.
    /// Required when connecting to HCP Terraform.
    /// Specifies which workspace(s) to associate with this configuration.
    /// </summary>
    public CloudWorkspacesBlock? Workspaces
    {
        get => GetArgument<CloudWorkspacesBlock?>("workspaces");
        set => SetArgument("workspaces", value);
    }

    /// <summary>
    /// Cloud block resolves as an object: cloud = { ... }
    /// </summary>
    public IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var map = new TerraformMapExpression();

        foreach (var kvp in _properties)
        {
            var key = kvp.Key;
            var value = kvp.Value;

            var resolvedNodes = value.ResolveNodes(context).ToList();
            if (resolvedNodes.Count == 1 && resolvedNodes[0] is TerraformExpression expr)
            {
                map.Add(key, expr);
            }
        }

        yield return map;
    }

    /// <summary>
    /// Gets a property value.
    /// </summary>
    protected T? GetArgument<T>(string key)
        => _properties.TryGetValue(key, out var value) && value is T typedValue ? typedValue : default;

    /// <summary>
    /// Gets a required property value.
    /// </summary>
    protected T GetRequiredArgument<T>(string key)
        => GetArgument<T>(key) ?? throw new InvalidOperationException($"Required property '{key}' is not set.");

    /// <summary>
    /// Sets a property value.
    /// </summary>
    protected void SetArgument(string key, ITerraformValue? value)
    {
        if (value is not null)
        {
            _properties[key] = value;
        }
        else if (_properties.ContainsKey(key))
        {
            _properties.Remove(key);
        }
    }
}

/// <summary>
/// Represents the workspaces block within the cloud block.
/// Specifies metadata for matching workspaces in HCP Terraform.
/// See: https://developer.hashicorp.com/terraform/language/block/terraform#workspaces
/// </summary>
public partial class CloudWorkspacesBlock : ITerraformResolvable, ITerraformValue
{
    private readonly Dictionary<string, ITerraformValue> _properties = new();

    /// <summary>
    /// Initializes a new instance of CloudWorkspacesBlock.
    /// </summary>
    public CloudWorkspacesBlock() { }

    /// <summary>
    /// Gets whether this value has content.
    /// </summary>
    public bool HasValue => true;

    /// <summary>
    /// Gets or sets the workspace name to associate the configuration with.
    /// Mutually exclusive with Tags.
    /// Can be overridden by TF_WORKSPACE environment variable.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>?>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Gets or sets workspace tags for matching multiple workspaces.
    /// Mutually exclusive with Name.
    /// New workspaces created from the working directory inherit these tags.
    /// For Terraform &lt; 1.10 or TFE &lt; v202411-1, use simple string tags.
    /// For newer versions, can be key-value pairs using object syntax.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>?>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Gets or sets the name of an HCP Terraform project.
    /// All workspaces using this configuration are created in this project.
    /// Can be overridden by TF_CLOUD_PROJECT environment variable.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>?>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Workspaces block resolves as an object: workspaces = { ... }
    /// </summary>
    public IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var map = new TerraformMapExpression();

        foreach (var kvp in _properties)
        {
            var key = kvp.Key;
            var value = kvp.Value;

            var resolvedNodes = value.ResolveNodes(context).ToList();
            if (resolvedNodes.Count == 1 && resolvedNodes[0] is TerraformExpression expr)
            {
                map.Add(key, expr);
            }
        }

        yield return map;
    }

    /// <summary>
    /// Gets a property value.
    /// </summary>
    protected T? GetArgument<T>(string key)
        => _properties.TryGetValue(key, out var value) && value is T typedValue ? typedValue : default;

    /// <summary>
    /// Gets a required property value.
    /// </summary>
    protected T GetRequiredArgument<T>(string key)
        => GetArgument<T>(key) ?? throw new InvalidOperationException($"Required property '{key}' is not set.");

    /// <summary>
    /// Sets a property value.
    /// </summary>
    protected void SetArgument(string key, ITerraformValue? value)
    {
        if (value is not null)
        {
            _properties[key] = value;
        }
        else if (_properties.ContainsKey(key))
        {
            _properties.Remove(key);
        }
    }
}
