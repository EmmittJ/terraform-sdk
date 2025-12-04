using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_addresses Terraform data source.
/// Retrieves information about a google_compute_addresses.
/// </summary>
public partial class GoogleComputeAddressesDataSource(string name) : TerraformDataSource("google_compute_addresses", name)
{
    /// <summary>
    /// Filter sets the optional parameter &amp;quot;filter&amp;quot;: A filter expression that
    /// filters resources listed in the response. The expression must specify
    /// the field name, an operator, and the value that you want to use for
    /// filtering. The value must be a string, a number, or a boolean. The
    /// operator must be either &amp;quot;=&amp;quot;, &amp;quot;!=&amp;quot;, &amp;quot;&amp;gt;&amp;quot;, &amp;quot;&amp;lt;&amp;quot;, &amp;quot;&amp;lt;=&amp;quot;, &amp;quot;&amp;gt;=&amp;quot; or &amp;quot;:&amp;quot;. For
    /// example, if you are filtering Compute Engine instances, you can
    /// exclude instances named &amp;quot;example-instance&amp;quot; by specifying &amp;quot;name !=
    /// example-instance&amp;quot;. The &amp;quot;:&amp;quot; operator can be used with string fields to
    /// match substrings. For non-string fields it is equivalent to the &amp;quot;=&amp;quot;
    /// operator. The &amp;quot;:*&amp;quot; comparison can be used to test whether a key has
    /// been defined. For example, to find all objects with &amp;quot;owner&amp;quot; label
    /// use: &amp;quot;&amp;quot;&amp;quot; labels.owner:* &amp;quot;&amp;quot;&amp;quot; You can also filter nested fields. For
    /// example, you could specify &amp;quot;scheduling.automaticRestart = false&amp;quot; to
    /// include instances only if they are not scheduled for automatic
    /// restarts. You can use filtering on nested fields to filter based on
    /// resource labels. To filter on multiple expressions, provide each
    /// separate expression within parentheses. For example: &amp;quot;&amp;quot;&amp;quot;
    /// (scheduling.automaticRestart = true) (cpuPlatform = &amp;quot;Intel Skylake&amp;quot;)
    /// &amp;quot;&amp;quot;&amp;quot; By default, each expression is an &amp;quot;AND&amp;quot; expression. However, you
    /// can include &amp;quot;AND&amp;quot; and &amp;quot;OR&amp;quot; expressions explicitly. For example: &amp;quot;&amp;quot;&amp;quot;
    /// (cpuPlatform = &amp;quot;Intel Skylake&amp;quot;) OR (cpuPlatform = &amp;quot;Intel Broadwell&amp;quot;)
    /// AND (scheduling.automaticRestart = true) &amp;quot;&amp;quot;&amp;quot;
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The google project in which addresses are listed. Defaults to provider&#39;s configuration if missing.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region that should be considered to search addresses. All regions are considered if missing.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Addresses
        => AsReference("addresses");

}
