using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCoreNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_core_network resource.
/// </summary>
public class AwsNetworkmanagerCoreNetwork : TerraformResource
{
    public AwsNetworkmanagerCoreNetwork(string name) : base("aws_networkmanager_core_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("edges");
        this.WithOutput("segments");
        this.WithOutput("state");
    }

    /// <summary>
    /// The base_policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? BasePolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("base_policy_document");
        set => this.WithProperty("base_policy_document", value);
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? BasePolicyRegions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("base_policy_regions");
        set => this.WithProperty("base_policy_regions", value);
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateBasePolicy
    {
        get => GetProperty<TerraformProperty<bool>>("create_base_policy");
        set => this.WithProperty("create_base_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerCoreNetworkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerCoreNetworkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The edges attribute.
    /// </summary>
    public TerraformExpression Edges => this["edges"];

    /// <summary>
    /// The segments attribute.
    /// </summary>
    public TerraformExpression Segments => this["segments"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
