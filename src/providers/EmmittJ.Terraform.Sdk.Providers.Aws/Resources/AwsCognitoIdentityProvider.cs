using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_provider resource.
/// </summary>
public class AwsCognitoIdentityProvider : TerraformResource
{
    public AwsCognitoIdentityProvider(string name) : base("aws_cognito_identity_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attribute_mapping");
        SetOutput("id");
        SetOutput("idp_identifiers");
        SetOutput("provider_details");
        SetOutput("provider_name");
        SetOutput("provider_type");
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The attribute_mapping attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AttributeMapping
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("attribute_mapping");
        set => SetProperty("attribute_mapping", value);
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
    /// The idp_identifiers attribute.
    /// </summary>
    public List<TerraformProperty<string>> IdpIdentifiers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("idp_identifiers");
        set => SetProperty("idp_identifiers", value);
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderDetails is required")]
    public Dictionary<string, TerraformProperty<string>> ProviderDetails
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("provider_details");
        set => SetProperty("provider_details", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformProperty<string> ProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provider_name");
        set => SetProperty("provider_name", value);
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    public required TerraformProperty<string> ProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provider_type");
        set => SetProperty("provider_type", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

}
