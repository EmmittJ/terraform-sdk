using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for mount_options in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationSmbMountOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_smb resource.
/// </summary>
public class AwsDatasyncLocationSmb : TerraformResource
{
    public AwsDatasyncLocationSmb(string name) : base("aws_datasync_location_smb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public HashSet<TerraformProperty<string>>? AgentArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    public required TerraformProperty<string> ServerHostname
    {
        get => GetProperty<TerraformProperty<string>>("server_hostname");
        set => this.WithProperty("server_hostname", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformProperty<string> Subdirectory
    {
        get => GetProperty<TerraformProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

    /// <summary>
    /// Block for mount_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MountOptions block(s) allowed")]
    public List<AwsDatasyncLocationSmbMountOptionsBlock>? MountOptions
    {
        get => GetProperty<List<AwsDatasyncLocationSmbMountOptionsBlock>>("mount_options");
        set => this.WithProperty("mount_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
