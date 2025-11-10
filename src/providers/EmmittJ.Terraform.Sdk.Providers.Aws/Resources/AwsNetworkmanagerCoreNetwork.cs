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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("edges");
        SetOutput("segments");
        SetOutput("state");
        SetOutput("base_policy_document");
        SetOutput("base_policy_regions");
        SetOutput("create_base_policy");
        SetOutput("description");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The base_policy_document attribute.
    /// </summary>
    public TerraformProperty<string> BasePolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_policy_document");
        set => SetProperty("base_policy_document", value);
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> BasePolicyRegions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("base_policy_regions");
        set => SetProperty("base_policy_regions", value);
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public TerraformProperty<bool> CreateBasePolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_base_policy");
        set => SetProperty("create_base_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_network_id");
        set => SetProperty("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerCoreNetworkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
