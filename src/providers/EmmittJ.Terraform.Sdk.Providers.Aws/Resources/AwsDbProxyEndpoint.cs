using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbProxyEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a aws_db_proxy_endpoint resource.
/// </summary>
public class AwsDbProxyEndpoint : TerraformResource
{
    public AwsDbProxyEndpoint(string name) : base("aws_db_proxy_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("endpoint");
        this.WithOutput("is_default");
        this.WithOutput("vpc_id");
    }

    /// <summary>
    /// The db_proxy_endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyEndpointName is required")]
    public required TerraformProperty<string> DbProxyEndpointName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_proxy_endpoint_name");
        set => this.WithProperty("db_proxy_endpoint_name", value);
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformProperty<string> DbProxyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_proxy_name");
        set => this.WithProperty("db_proxy_name", value);
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
    /// The target_role attribute.
    /// </summary>
    public TerraformProperty<string>? TargetRole
    {
        get => GetProperty<TerraformProperty<string>>("target_role");
        set => this.WithProperty("target_role", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public HashSet<TerraformProperty<string>>? VpcSubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_subnet_ids");
        set => this.WithProperty("vpc_subnet_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbProxyEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbProxyEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
