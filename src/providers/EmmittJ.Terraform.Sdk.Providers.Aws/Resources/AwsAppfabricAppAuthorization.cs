using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credential in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationCredentialBlock : TerraformBlock
{
}

/// <summary>
/// Block type for tenant in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationTenantBlock : TerraformBlock
{
    /// <summary>
    /// The tenant_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantDisplayName is required")]
    public required TerraformProperty<string> TenantDisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tenant_display_name");
        set => WithProperty("tenant_display_name", value);
    }

    /// <summary>
    /// The tenant_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantIdentifier is required")]
    public required TerraformProperty<string> TenantIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tenant_identifier");
        set => WithProperty("tenant_identifier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAppfabricAppAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_appfabric_app_authorization resource.
/// </summary>
public class AwsAppfabricAppAuthorization : TerraformResource
{
    public AwsAppfabricAppAuthorization(string name) : base("aws_appfabric_app_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("auth_url");
        this.WithOutput("created_at");
        this.WithOutput("id");
        this.WithOutput("persona");
        this.WithOutput("tags_all");
        this.WithOutput("updated_at");
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    public required TerraformProperty<string> App
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app");
        set => this.WithProperty("app", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformProperty<string> AppBundleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_bundle_arn");
        set => this.WithProperty("app_bundle_arn", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auth_type");
        set => this.WithProperty("auth_type", value);
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
    /// Block for credential.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppfabricAppAuthorizationCredentialBlock>? Credential
    {
        get => GetProperty<List<AwsAppfabricAppAuthorizationCredentialBlock>>("credential");
        set => this.WithProperty("credential", value);
    }

    /// <summary>
    /// Block for tenant.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppfabricAppAuthorizationTenantBlock>? Tenant
    {
        get => GetProperty<List<AwsAppfabricAppAuthorizationTenantBlock>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAppfabricAppAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAppfabricAppAuthorizationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth_url attribute.
    /// </summary>
    public TerraformExpression AuthUrl => this["auth_url"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The persona attribute.
    /// </summary>
    public TerraformExpression Persona => this["persona"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
