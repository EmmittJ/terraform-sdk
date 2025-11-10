using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_api_cache resource.
/// </summary>
public class AwsAppsyncApiCache : TerraformResource
{
    public AwsAppsyncApiCache(string name) : base("aws_appsync_api_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_caching_behavior");
        SetOutput("api_id");
        SetOutput("at_rest_encryption_enabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("transit_encryption_enabled");
        SetOutput("ttl");
        SetOutput("type");
    }

    /// <summary>
    /// The api_caching_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiCachingBehavior is required")]
    public required TerraformProperty<string> ApiCachingBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_caching_behavior");
        set => SetProperty("api_caching_behavior", value);
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AtRestEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("at_rest_encryption_enabled");
        set => SetProperty("at_rest_encryption_enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TransitEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transit_encryption_enabled");
        set => SetProperty("transit_encryption_enabled", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformProperty<double> Ttl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ttl");
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

}
