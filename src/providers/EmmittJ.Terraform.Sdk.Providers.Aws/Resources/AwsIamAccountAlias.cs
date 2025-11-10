using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_alias resource.
/// </summary>
public class AwsIamAccountAlias : TerraformResource
{
    public AwsIamAccountAlias(string name) : base("aws_iam_account_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_alias");
        SetOutput("id");
    }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAlias is required")]
    public required TerraformProperty<string> AccountAlias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_alias");
        set => SetProperty("account_alias", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

}
