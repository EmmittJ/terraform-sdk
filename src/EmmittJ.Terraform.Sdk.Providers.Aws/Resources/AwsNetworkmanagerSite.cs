using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for location in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerSiteLocationBlock : TerraformBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => WithProperty("address", value);
    }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    public TerraformProperty<string>? Latitude
    {
        get => GetProperty<TerraformProperty<string>>("latitude");
        set => WithProperty("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    public TerraformProperty<string>? Longitude
    {
        get => GetProperty<TerraformProperty<string>>("longitude");
        set => WithProperty("longitude", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerSiteTimeoutsBlock : TerraformBlock
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
/// Manages a aws_networkmanager_site resource.
/// </summary>
public class AwsNetworkmanagerSite : TerraformResource
{
    public AwsNetworkmanagerSite(string name) : base("aws_networkmanager_site", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
        get => GetProperty<TerraformProperty<string>>("global_network_id");
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
    /// Block for location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public List<AwsNetworkmanagerSiteLocationBlock>? Location
    {
        get => GetProperty<List<AwsNetworkmanagerSiteLocationBlock>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerSiteTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerSiteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
