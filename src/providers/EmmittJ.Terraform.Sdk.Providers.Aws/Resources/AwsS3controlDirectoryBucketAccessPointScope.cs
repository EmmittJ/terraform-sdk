using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlDirectoryBucketAccessPointScopeScopeBlock : TerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<List<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Prefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("prefixes");
        set => WithProperty("prefixes", value);
    }

}

/// <summary>
/// Manages a aws_s3control_directory_bucket_access_point_scope resource.
/// </summary>
public class AwsS3controlDirectoryBucketAccessPointScope : TerraformResource
{
    public AwsS3controlDirectoryBucketAccessPointScope(string name) : base("aws_s3control_directory_bucket_access_point_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>? Scope
    {
        get => GetProperty<List<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>>("scope");
        set => this.WithProperty("scope", value);
    }

}
