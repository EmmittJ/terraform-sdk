using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53ZoneTimeoutsBlock : TerraformBlock
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
/// Block type for vpc in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53ZoneVpcBlock : TerraformBlock
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    public TerraformProperty<string>? VpcRegion
    {
        get => GetProperty<TerraformProperty<string>>("vpc_region");
        set => WithProperty("vpc_region", value);
    }

}

/// <summary>
/// Manages a aws_route53_zone resource.
/// </summary>
public class AwsRoute53Zone : TerraformResource
{
    public AwsRoute53Zone(string name) : base("aws_route53_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("name_servers");
        this.WithOutput("primary_name_server");
        this.WithOutput("zone_id");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The delegation_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegationSetId
    {
        get => GetProperty<TerraformProperty<string>>("delegation_set_id");
        set => this.WithProperty("delegation_set_id", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public AwsRoute53ZoneTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53ZoneTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53ZoneVpcBlock>? Vpc
    {
        get => GetProperty<HashSet<AwsRoute53ZoneVpcBlock>>("vpc");
        set => this.WithProperty("vpc", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    public TerraformExpression PrimaryNameServer => this["primary_name_server"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}
