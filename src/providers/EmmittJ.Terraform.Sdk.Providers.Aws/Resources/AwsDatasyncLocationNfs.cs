using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for mount_options in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationNfsMountOptionsBlock : TerraformBlock
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
/// Block type for on_prem_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationNfsOnPremConfigBlock : TerraformBlock
{
    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public HashSet<TerraformProperty<string>>? AgentArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("agent_arns");
        set => WithProperty("agent_arns", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_nfs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationNfs : TerraformResource
{
    public AwsDatasyncLocationNfs(string name) : base("aws_datasync_location_nfs", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("uri");
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
        get => GetRequiredProperty<TerraformProperty<string>>("server_hostname");
        set => this.WithProperty("server_hostname", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformProperty<string> Subdirectory
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subdirectory");
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
    /// Block for mount_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MountOptions block(s) allowed")]
    public List<AwsDatasyncLocationNfsMountOptionsBlock>? MountOptions
    {
        get => GetProperty<List<AwsDatasyncLocationNfsMountOptionsBlock>>("mount_options");
        set => this.WithProperty("mount_options", value);
    }

    /// <summary>
    /// Block for on_prem_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OnPremConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnPremConfig block(s) allowed")]
    public List<AwsDatasyncLocationNfsOnPremConfigBlock>? OnPremConfig
    {
        get => GetProperty<List<AwsDatasyncLocationNfsOnPremConfigBlock>>("on_prem_config");
        set => this.WithProperty("on_prem_config", value);
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
