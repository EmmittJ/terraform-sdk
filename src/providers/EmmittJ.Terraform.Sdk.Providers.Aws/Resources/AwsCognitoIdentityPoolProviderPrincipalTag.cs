using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool_provider_principal_tag resource.
/// </summary>
public class AwsCognitoIdentityPoolProviderPrincipalTag : TerraformResource
{
    public AwsCognitoIdentityPoolProviderPrincipalTag(string name) : base("aws_cognito_identity_pool_provider_principal_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("identity_pool_id");
        SetOutput("identity_provider_name");
        SetOutput("principal_tags");
        SetOutput("region");
        SetOutput("use_defaults");
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
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformProperty<string> IdentityPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_pool_id");
        set => SetProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    public required TerraformProperty<string> IdentityProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_provider_name");
        set => SetProperty("identity_provider_name", value);
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> PrincipalTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("principal_tags");
        set => SetProperty("principal_tags", value);
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
    /// The use_defaults attribute.
    /// </summary>
    public TerraformProperty<bool> UseDefaults
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_defaults");
        set => SetProperty("use_defaults", value);
    }

}
