using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_canonical_user_id.
/// </summary>
public class AwsCanonicalUserIdDataSource : TerraformDataSource
{
    public AwsCanonicalUserIdDataSource(string name) : base("aws_canonical_user_id", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("id");
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
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
