namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the cloud block configuration for HCP Terraform or Terraform Enterprise.
/// Provides state storage, remote execution, and other cloud-based features.
/// Mutually exclusive with backend configuration.
/// See: https://developer.hashicorp.com/terraform/language/block/terraform#cloud
/// </summary>
public class TerraformCloudConfig
{
    /// <summary>
    /// Gets or sets the name of the organization to connect to.
    /// Required when connecting to HCP Terraform.
    /// Can be overridden by TF_CLOUD_ORGANIZATION environment variable.
    /// </summary>
    public string? Organization { get; set; }

    /// <summary>
    /// Gets or sets the hostname for a Terraform Enterprise deployment.
    /// Default: "app.terraform.io" (HCP Terraform)
    /// Can be overridden by TF_CLOUD_HOSTNAME environment variable.
    /// </summary>
    public string? Hostname { get; set; }

    /// <summary>
    /// Gets or sets the authentication token for HCP Terraform.
    /// We recommend omitting this and using 'terraform login' or CLI config file instead.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    /// Gets or sets the workspace configuration.
    /// Required when connecting to HCP Terraform.
    /// Specifies which workspace(s) to associate with this configuration.
    /// </summary>
    public CloudWorkspaceConfig? Workspaces { get; set; }
}

/// <summary>
/// Represents workspace configuration for the cloud block.
/// Specifies metadata for matching workspaces in HCP Terraform.
/// See: https://developer.hashicorp.com/terraform/language/block/terraform#workspaces
/// </summary>
public class CloudWorkspaceConfig
{
    /// <summary>
    /// Gets or sets the workspace name to associate the configuration with.
    /// Mutually exclusive with Tags.
    /// Can be overridden by TF_WORKSPACE environment variable.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets workspace tags for matching multiple workspaces.
    /// Mutually exclusive with Name.
    /// New workspaces created from the working directory inherit these tags.
    /// For Terraform &lt; 1.10 or TFE &lt; v202411-1, use simple string tags.
    /// For newer versions, can be key-value pairs using object syntax.
    /// </summary>
    public List<string>? Tags { get; set; }

    /// <summary>
    /// Gets or sets the name of an HCP Terraform project.
    /// All workspaces using this configuration are created in this project.
    /// Can be overridden by TF_CLOUD_PROJECT environment variable.
    /// </summary>
    public string? Project { get; set; }
}
