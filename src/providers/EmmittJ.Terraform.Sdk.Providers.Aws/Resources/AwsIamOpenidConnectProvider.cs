using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_openid_connect_provider resource.
/// </summary>
public class AwsIamOpenidConnectProvider : TerraformResource
{
    public AwsIamOpenidConnectProvider(string name) : base("aws_iam_openid_connect_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("client_id_list");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("thumbprint_list");
        SetOutput("url");
    }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientIdList is required")]
    public HashSet<TerraformProperty<string>> ClientIdList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("client_id_list");
        set => SetProperty("client_id_list", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    public List<TerraformProperty<string>> ThumbprintList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("thumbprint_list");
        set => SetProperty("thumbprint_list", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
